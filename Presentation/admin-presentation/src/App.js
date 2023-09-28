import Home from "./pages/home/Home";
import List from './pages/list/List';
import New from './pages/new/New';
import Single from "./pages/single/Single";
import {
  createBrowserRouter,
  RouterProvider,
  Route,
  Link,
} from "react-router-dom";


const router = createBrowserRouter([
  {
    path: "/",
    element: <Home />
  },
  {
    path: "user/list",
    element: <List />,
  },
  {
    path: "user/new",
    element: <New />
  },
  {
    path: "user/:userId",
    element: <Single />
  }
]);

function App() {
  return (
    <div>
      <RouterProvider router={router} />
    </div>
  );
}

export default App;
