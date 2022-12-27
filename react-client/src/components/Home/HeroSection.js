import HeroSectionImg from './Images/hero-section-farmer.jpg';
import { Link } from 'react-router-dom';
import { translate } from '../Translator';

const HeroSection = () => {
  return (
    <div className=''>
      <div className='row' style={{ height: '80vh' }}>
        <div className='col-lg-6 d-flex align-items-center justify-content-center'>
          <div>
            <h1>Facilitating Farmers</h1>
            <h4>{translate('Home.HeroSectionSubtitle.1')}</h4>
            <Link to='/home' className='btn btn-secondary p-4 mt-3 w-100'>
              <h4>{translate('Course.Btn.2')}</h4>
            </Link>
          </div>
        </div>
        <div className='col-lg-6 d-flex align-items-center justify-content-center'>
          <img
            src={HeroSectionImg}
            alt=''
            style={{ width: '500px' }}
            className='shadow-lg'
          />
        </div>
      </div>
    </div>
  );
};

export default HeroSection;
