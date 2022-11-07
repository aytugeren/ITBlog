using AutoMapper;
using ITBlog.Business.DTO;
using ITBlog.Business.Enums;
using ITBlog.DataAccess.RepositoryFolder;
using ITBlog.Entities.Concrete.SubscriberFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITBlog.Business.SubscriberServiceFolder
{
    public class SubscriberService : ISubscriberService
    {
        private readonly IRepository<Subscriber> _subscriberRepository;
        private readonly IMapper _mapper;

        public SubscriberService(IRepository<Subscriber> subscriberRepository, IMapper mapper)
        {
            _subscriberRepository = subscriberRepository;
            _mapper = mapper;
        }

        public string AddOrUpdateTheSubscriber(string email)
        {
            if (!string.IsNullOrEmpty(email))
            {
                var suber = _subscriberRepository.Query(x => x.SubscriberEmail == email, string.Empty).FirstOrDefault();
                
                if (suber != null)
                {
                    return DbStatuEnums.EntityStillCreated.ToString();
                }
                else
                {
                    SubscriberDTO model = new SubscriberDTO();
                    model.SubscriberEmail = email;
                    model.IsActivedTheEmail = false;

                    var mappedModel = _mapper.Map<Subscriber>(model);

                    try
                    {
                        _subscriberRepository.Insert(mappedModel);
                        return DbStatuEnums.EntityCreated.ToString();
                    }
                    catch (Exception)
                    {
                        return DbStatuEnums.EntityError.ToString();
                    }
                }
            }

            return DbStatuEnums.EntityError.ToString();
        }
    }
}
