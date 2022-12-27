// import { Link } from 'react-router-dom';
// import CourseImg from './Images/services-section-online-course.jpg';
// import SpecialistImg from './Images/services-section-specialist.jpg';
// import QA from './Images/services-section-q-and-a.jpg';
// import BuySell from './Images/services-section-buy-and-sell.jpg';
// import { translate } from '../Translator';

const Reviews = () => {
  return (
    <section>
      <h3 className='mb-4 p-3 text-center shadow mb-3 w-100'>Testimonials</h3>

      <div className='container'>
        <div
          class='row text-center d-flex align-items-stretch'
          style={{ marginTop: '5rem' }}
        >
          <div class='col-md-4 mb-5 mb-md-0 d-flex align-items-stretch'>
            <div class='card testimonial-card'>
              <div class='card-up' style={{ backgroundColor: '#9d789b' }}></div>
              <div class='avatar mx-auto bg-white'>
                <img
                  src='https://mdbcdn.b-cdn.net/img/Photos/Avatars/img%20(1).webp'
                  class='rounded-circle img-fluid'
                  alt='customer1'
                />
              </div>
              <div class='card-body'>
                <h4 class='mb-4'>Maria Smantha</h4>
                <hr />
                <p class='dark-grey-text mt-4'>
                  <i class='fas fa-quote-left pe-2'></i>Lorem ipsum dolor sit
                  amet eos adipisci, consectetur adipisicing elit.
                </p>
              </div>
            </div>
          </div>
          <div class='col-md-4 mb-5 mb-md-0 d-flex align-items-stretch'>
            <div class='card testimonial-card'>
              <div class='card-up' style={{ backgroundColor: '#7a81a8' }}></div>
              <div class='avatar mx-auto bg-white'>
                <img
                  src='https://mdbcdn.b-cdn.net/img/Photos/Avatars/img%20(2).webp'
                  class='rounded-circle img-fluid'
                  alt='customer2'
                />
              </div>
              <div class='card-body'>
                <h4 class='mb-4'>Lisa Cudrow</h4>
                <hr />
                <p class='dark-grey-text mt-4'>
                  <i class='fas fa-quote-left pe-2'></i>Neque cupiditate
                  assumenda in maiores repudi mollitia architecto.
                </p>
              </div>
            </div>
          </div>
          <div class='col-md-4 mb-0 d-flex align-items-stretch'>
            <div class='card testimonial-card'>
              <div class='card-up' style={{ backgroundColor: '#6d5b98' }}></div>
              <div class='avatar mx-auto bg-white'>
                <img
                  src='https://images.newindianexpress.com/uploads/user/imagelibrary/2019/8/19/original/ChandlerBing1.JPG'
                  class='rounded-circle img-fluid'
                  alt='customer3'
                />
              </div>
              <div class='card-body'>
                <h4 class='mb-4'>Chandler King</h4>
                <hr />
                <p class='dark-grey-text mt-4'>
                  <i class='fas fa-quote-left pe-2'></i>So it seems like this
                  internet thing is here to stay.
                </p>
              </div>
            </div>
          </div>
        </div>
      </div>
    </section>
  );
};

export default Reviews;
