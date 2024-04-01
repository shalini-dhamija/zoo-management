import React, { useState } from "react";
import { Link, useLocation } from "react-router-dom";
import "./styles.scss";

const NavBar : React.FC= () => {
  const location = useLocation();

  const [showMenu, setShowMenu] = useState(false);

  const toggleMenu = () => {
    setShowMenu(!showMenu);
  };

  const closeMenuOnMobile = () => {
    setShowMenu(false);
  };

  return (
    <>
      <header className="header">
        <nav
          className={`navbar ${location.pathname === "/" ? "collapsed" : ""}`}
        >
          <ul className={`nav-menu ${showMenu ? "active" : ""}`}>
            <li className="nav-item">
              <Link className="nav-link" to="/" onClick={closeMenuOnMobile}>
                Home
              </Link>
            </li>
            <li className="nav-item">
              <Link
                className="nav-link"
                to="/listanimal"
                onClick={closeMenuOnMobile}
              >
                Animals
              </Link>
            </li>
            
          </ul>
          <div
            className={`hamburger ${showMenu ? "active" : ""}`}
            onClick={toggleMenu}
          >
            <span className="bar"></span>
            <span className="bar"></span>
            <span className="bar"></span>
          </div>
        </nav>
      </header>
      <div
        className={`overlay ${showMenu ? "show" : ""}`}
        onClick={closeMenuOnMobile}
      ></div>
    </>
  );
};

export default NavBar;
