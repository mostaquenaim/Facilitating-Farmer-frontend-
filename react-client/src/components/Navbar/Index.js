import { NavLink, Link } from 'react-router-dom';
import { translate } from '../Translator';
import handleTranslation from './handleTranslation';

const Navbar = () => {
  return (
    <nav className='navbar navbar-expand-lg bg-light'>
      <div className='container-fluid'>
        <NavLink to='/' className='navbar-brand'>
          <img
            src='harvest-farming.png'
            alt='logo'
            style={{ width: '15%' }}
          ></img>
        </NavLink>

        <button
          className='navbar-toggler'
          type='button'
          data-bs-toggle='collapse'
          data-bs-target='#navbarNav'
          aria-controls='navbarNav'
          aria-expanded='false'
          aria-label='Toggle navigation'
        >
          <span className='navbar-toggler-icon'></span>
        </button>
        <div className='collapse navbar-collapse' id='navbarNav'>
          <ul className='navbar-nav ms-auto'>
            <li className='nav-item p-2'>
              <NavLink to={'/courses'} className='nav-link'>
                {translate('Course.Btn.1')}
              </NavLink>
            </li>
            <li className='nav-item p-2'>
              <NavLink to={'/specialists'} className='nav-link'>
                {translate('Specialist.Btn.1')}
              </NavLink>
            </li>
            <li className='nav-item p-2'>
              <NavLink to={'/question-answers'} className='nav-link'>
                {translate('QA.Btn.1')}
              </NavLink>
            </li>
            <li className='nav-item p-2'>
              <NavLink to={'/buy-sell'} className='nav-link'>
                {translate('BuySell.Btn.1')}
              </NavLink>
            </li>
            <li className='nav-item p-2'>
              <button
                className=' btn btn-secondary'
                value='en'
                onClick={(e) => handleTranslation(e, 'value')}
              >
                {localStorage.getItem('languageBtn') ?? 'English'}
              </button>
            </li>
            <li className='nav-item p-2'>
              <Link to={'/login'} className='btn btn-secondary'>
                {translate('SignIn.1')}
              </Link>
            </li>
          </ul>
        </div>
      </div>
    </nav>
  );
};

// Specialist Navbar
export const NavbarSpecialist = () => {
  return (
    <nav className='navbar navbar-expand-lg bg-light'>
      <div className='container-fluid'>
        <NavLink to='/' className='navbar-brand'>
          <img
            src='harvest-farming.png'
            alt='logo'
            style={{ width: '15%' }}
          ></img>
        </NavLink>

        <button
          className='navbar-toggler'
          type='button'
          data-bs-toggle='collapse'
          data-bs-target='#navbarNav'
          aria-controls='navbarNav'
          aria-expanded='false'
          aria-label='Toggle navigation'
        >
          <span className='navbar-toggler-icon'></span>
        </button>
        <div className='collapse navbar-collapse' id='navbarNav'>
          <ul className='navbar-nav ms-auto'>
            <li className='nav-item p-2'>
              <NavLink to={'/'} className='nav-link'>
                Home
              </NavLink>
            </li>
            <li className='nav-item p-2'>
              <NavLink to={''} className='nav-link'>
                Courses uploaded
              </NavLink>
            </li>
            <li className='nav-item p-2'>
              <NavLink to={''} className='nav-link'>
                Question & Answers
              </NavLink>
            </li>
            <li className='nav-item p-2'>
              <NavLink to={''} className='nav-link'>
                Create Meeting
              </NavLink>
            </li>
            <li className='nav-item p-2'>
              <button
                className=' btn btn-secondary'
                value='en'
                onClick={(e) => handleTranslation(e, 'value')}
              >
                {localStorage.getItem('languageBtn') ?? 'English'}
              </button>
            </li>
            <li className='nav-item p-2'>
              <Link to={'/logout'} className='btn btn-secondary'>
                Logout
              </Link>
            </li>
          </ul>
        </div>
      </div>
    </nav>
  );
};

// Customer navbar
export const CustomerNav = () => {
  return (
    <nav className='navbar navbar-expand-lg bg-light'>
      <div className='container-fluid'>
        <NavLink to='/' className='navbar-brand'>
          <img
            src='harvest-farming.png'
            alt='logo'
            style={{ width: '15%' }}
          ></img>
        </NavLink>

        <button
          className='navbar-toggler'
          type='button'
          data-bs-toggle='collapse'
          data-bs-target='#navbarNav'
          aria-controls='navbarNav'
          aria-expanded='false'
          aria-label='Toggle navigation'
        >
          <span className='navbar-toggler-icon'></span>
        </button>
        <div className='collapse navbar-collapse' id='navbarNav'>
          <ul className='navbar-nav ms-auto'>
            <li className='nav-item p-2'>
              <NavLink to={'/'} className='nav-link'>
                Home
              </NavLink>
            </li>
            <li className='nav-item p-2'>
              <NavLink to={''} className='nav-link'>
                Courses
              </NavLink>
            </li>
            <li className='nav-item p-2'>
              <NavLink to={''} className='nav-link'>
                Question & Answers
              </NavLink>
            </li>
            <li className='nav-item p-2'>
              <NavLink to={''} className='nav-link'>
                Ongoing Meetings
              </NavLink>
            </li>
            <li className='nav-item p-2'>
              <NavLink to={''} className='nav-link'>
                Buy/Sell
              </NavLink>
            </li>
            <li className='nav-item p-2'>
              <button
                className=' btn btn-secondary'
                value='en'
                onClick={(e) => handleTranslation(e, 'value')}
              >
                {localStorage.getItem('languageBtn') ?? 'English'}
              </button>
            </li>
            <li className='nav-item p-2'>
              <Link to={'/logout'} className='btn btn-secondary'>
                Logout
              </Link>
            </li>
          </ul>
        </div>
      </div>
    </nav>
  );
};

export default Navbar;
