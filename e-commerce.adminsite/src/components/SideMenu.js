import React, { useEffect, useState } from "react";
import {
  AiOutlineArrowRight,
  AiOutlineArrowLeft,
} from "react-icons/ai";
import {
  BsSearch,
  BsFillPersonLinesFill,
  BsThreeDotsVertical,
} from "react-icons/bs";
import {
  RiDashboardFill,
} from "react-icons/ri";
import MenuItem from "./MenuItem";
import { Link, useNavigate } from "react-router-dom";
import logo from "../images/logo.png";
import cat from "../images/cat.jpg";


const menuItems = [
  {
    name: "Dashboard",
    to: "/",
    icon: <RiDashboardFill />,
    subMenus: [
      { name: "Classify", to: "/Classifys" },
      { name: "Feedback", to: "/products/feedback" },
    ],
  },
  {
    name: "Customer",
    to: "/Customer",
    exact: "true",
    icon: <BsFillPersonLinesFill />,
  },
];

const SideMenu = (props) => {
  const [inactive, setInactive] = useState(false);
  let navigate = useNavigate();
  useEffect(() => {
    if (inactive) {
      removeActiveClassFromSubMenu();
    }

    props.onCollapse(inactive);
  }, [inactive]);
  
  const removeActiveClassFromSubMenu = () => {
    document.querySelectorAll(".sub-menu").forEach((el) => {
      el.classList.remove("active");
    });
  };

  useEffect(() => {
    let menuItems = document.querySelectorAll(".menu-item");
    menuItems.forEach((el) => {
      el.addEventListener("click", (e) => {
        const next = el.nextElementSibling;
        removeActiveClassFromSubMenu();
        menuItems.forEach((el) => el.classList.remove("active"));
        el.classList.toggle("active");
        if (next !== null) {
          next.classList.toggle("active");
        }
      });
    });
  }, []);

  const logout = () => {
    window.sessionStorage.removeItem("employee-account");
    navigate("/");
    window.location.reload();
  };

  return (
    <div className={`side-menu ${inactive ? "inactive" : ""}`}>
      <div className="top-section">
        <div className="logo">
          <img src={logo} alt="" />
        </div>
        <div className="toggle-menu-btn" onClick={() => setInactive(!inactive)}>
          {inactive ? <AiOutlineArrowRight /> : <AiOutlineArrowLeft />}
        </div>
      </div>

      <div className="search-controller">
        <button className="search-btn">
          <BsSearch />
        </button>
        <input type="text" name="" id="" placeholder="Search here" />
      </div>
      <div className="divider"></div>
      <div className="main-menu">
        <ul>
          {menuItems.map((item, index) => (
            <MenuItem
              key={index}
              name={item.name}
              icon={item.icon}
              to={item.to}
              subMenus={item.subMenus || []}
              onClick={() => {
                if (inactive) {
                  setInactive(false);
                }
              }}
            />
          ))}
        </ul>
      </div>

      <div className="side-menu-footer">
        <div className="avatar">
          <img src={cat} alt="" />
        </div>
        <div className="user-info">
          <h5 style={{ marginBottom: "0" }}>Trần Gia Nhi</h5>
          <p>trangianhi1332000@gmail.com</p>
        </div>
        <div className="settings">
          <BsThreeDotsVertical />
          <ul className="table-content">
            <li className="list">
              <Link to="/#" className="list-link">Profile</Link>
            </li>
            <li className="list">
              <button className="btn-logout" onClick={logout}>Logout</button>
            </li>
          </ul>
        </div>
        <div style={{ height: "20px" }} />
      </div>
    </div>
  );
};

export default SideMenu;