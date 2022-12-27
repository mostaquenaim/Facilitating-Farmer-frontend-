import { Routes, Route } from 'react-router-dom';
import Home from './components/Home/Index';
import i18next from 'i18next';
import Login from './components/Login/Index';
import Signup from './components/Login/Signup';
import SplstDash from './components/Specialists/dashboard';
import CustomerDash from './components/Customer/dashboard';
import Logout from './components/Logout/Index';
import Course from './components/Courses/Index';

const App = () => {
  window.translateTo = (lang) => {
    i18next.changeLanguage(lang);
  };

  return (
    <>
      <Routes>
        <Route path='/' element={<Home />} />
        <Route path='/login' element={<Login />} />
        <Route path='/signup' element={<Signup />} />
        <Route path='/specialist-dashboard' element={<SplstDash />} />
        <Route path='/customer-dashboard' element={<CustomerDash />} />
        <Route path='/courses' element={<Course />} />
        <Route path='/logout' element={<Logout />} />
      </Routes>
    </>
  );
};

export default App;
