import { BrowserRouter as Router, Route, Routes } from "react-router-dom";
import './App.css'

import NavBar from "./Components/Navbar/Navbar.tsx";
import HomePage from "./Components/HomePage/Index.tsx";
import ListAnimal from "./Components/ListAnimal/Index.tsx";

function App() {
  return (
    <Router>
      <NavBar />
      <div className="padded-container">
        <Routes>
          <Route path="/" element={<HomePage />} />
          <Route path="/listanimal" element={<ListAnimal />} />
          </Routes>
      </div>
    </Router>
    
  );  
};

export default App
