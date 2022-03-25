
import "./global.style";
import { Routes, Route, BrowserRouter } from "react-router-dom";
import { useState } from "react";

import SideMenu from "./components/SideMenu";
import Dashboard from "./pages/Dashboard/Dashboard";
import EditProduct from "./pages/Product/EditProduct";
import AddNewProduct from "./pages/Product/AddNewProduct";
import Classifys from "./pages/Classify/Classifys"
import Customers from "./pages/Customer/Customer";


function App() {
  const [inactive, setInactive] = useState(false);
  
  return (
    <>
      <BrowserRouter>
      <SideMenu
                onCollapse={(inactive) => {
                  setInactive(inactive);
                }}
              />
              <div className={`container ${inactive ? "inactive" : ""}`}>
                <Routes>
                  <Route path="/" element={<Dashboard />} />
                  <Route path="/products/edit/:id" element={<EditProduct />} />
                  <Route path="/AddNewProduct" element={<AddNewProduct />}/>
                  <Route path="/Classifys" element={<Classifys />}/>
                  <Route path="/customer" element={<Customers />} />
                </Routes>
              </div>
      </BrowserRouter>
    </>
  );
}

export default App;
