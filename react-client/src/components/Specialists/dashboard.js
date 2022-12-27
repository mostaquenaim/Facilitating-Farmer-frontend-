import { NavbarSpecialist } from '../Navbar/Index';
import { useEffect } from 'react';
import { useNavigate } from 'react-router-dom';

const SplstDash = () => {
  const navigate = useNavigate();
  useEffect(() => {
    if (!localStorage.getItem('Bearer')) navigate('/');
  });

  return <NavbarSpecialist />;
};

export default SplstDash;
