import { Link } from 'react-router-dom';
import CourseImg from './Images/services-section-online-course.jpg';
import SpecialistImg from './Images/services-section-specialist.jpg';
import QA from './Images/services-section-q-and-a.jpg';
import BuySell from './Images/services-section-buy-and-sell.jpg';
import { translate } from '../Translator';

const Services = () => {
  return (
    <div className='mt-5'>
      <h3 className='p-3 text-center shadow mb-3'>
        {translate('Home.ServiceSectionHeader.1')}
      </h3>
      <div
        className='container vh-50 d-flex align-items-center justify-content-center'
        style={{ marginTop: '5rem' }}
      >
        <div className='row' style={{ marginBottom: '5rem' }}>
          {/* Courses */}
          <div className='col-lg-3 d-flex align-items-center justify-content-center'>
            <div className='card' style={{ width: '18rem' }}>
              <img
                className='card-img-top'
                src={CourseImg}
                alt='Online course'
              />
              <div className='card-body'>
                <h5 className='card-title text-center'>কোর্স</h5>
                <Link to='#' className='btn btn-secondary w-100 p-3'>
                  এখানে দেখুন
                </Link>
              </div>
            </div>
          </div>
          {/* Specialists */}
          <div className='col-lg-3 d-flex align-items-center justify-content-center'>
            <div className='card' style={{ width: '18rem' }}>
              <img
                className='card-img-top'
                src={SpecialistImg}
                alt='Specialist'
              />
              <div className='card-body'>
                <h5 className='card-title text-center'>বিশেষজ্ঞ</h5>
                <Link to='#' className='btn btn-secondary w-100 p-3'>
                  এখানে দেখুন
                </Link>
              </div>
            </div>
          </div>
          {/* Q & A */}
          <div className='col-lg-3 d-flex align-items-center justify-content-center'>
            <div className='card' style={{ width: '18rem' }}>
              <img className='card-img-top' src={QA} alt='Specialist' />
              <div className='card-body'>
                <h5 className='card-title text-center'>প্রশ্নোত্তর</h5>
                <Link to='#' className='btn btn-secondary w-100 p-3'>
                  এখানে দেখুন
                </Link>
              </div>
            </div>
          </div>
          {/* Buy and sell */}
          <div className='col-lg-3 d-flex align-items-center justify-content-center'>
            <div className='card' style={{ width: '18rem' }}>
              <img className='card-img-top' src={BuySell} alt='Buy and sell' />
              <div className='card-body'>
                <h5 className='card-title text-center'>ক্রয়/বিক্রয় </h5>
                <Link to='#' className='btn btn-secondary w-100 p-3'>
                  এখানে দেখুন
                </Link>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
};

export default Services;
