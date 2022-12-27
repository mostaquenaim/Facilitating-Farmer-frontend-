import { Link } from 'react-router-dom';

const Contact = () => {
  return (
    <section className='mt-5 mb-5'>
      <h3 className='mb-4 p-3 text-center shadow mb-3 w-100'>Contact Us</h3>
      <div className='container' style={{ marginTop: '5rem' }}>
        <div className='row'>
          <div className='col-lg-6'>
            <div className='row'>
              <div className='col-lg-6'>
                <h4>Account</h4>
                <p>
                  <Link to=''>Sign in</Link>
                  <br />
                  <Link to=''>Register</Link>
                </p>
              </div>
              <div className='col-lg-6'>
                <h4>Help</h4>
                <p>
                  <Link to=''>FAQ</Link>
                  <br />
                  <Link to=''>+8801768385687</Link>
                </p>
              </div>
            </div>

            <div className='row'>
              <div className='col-lg-6'>
                <h4>Related</h4>
                <p>
                  <Link to=''>Media</Link>
                  <br />
                  <Link to=''>Sustainablity</Link>
                </p>
              </div>
              <div className='col-lg-6'>
                <h4>Rules and Laws</h4>
                <p>
                  <Link to=''>Terms of use</Link>
                  <br />
                  <Link to=''>Terms of Sale</Link>
                  <br />
                  <Link to=''>Privacy Policy</Link>
                </p>
              </div>
            </div>
          </div>
          <div className='col-lg-6'>
            <form action='' method='post'>
              <input
                type='text'
                name=''
                id=''
                className='w-100 p-2'
                placeholder='Enter your name'
              />
              <input
                type='text'
                name=''
                id=''
                className='w-100 p-2 mt-3'
                placeholder='Enter your phone number'
              />
              <textarea
                name=''
                id=''
                cols='30'
                rows='10'
                className='w-100 mt-3 p-2'
                placeholder='Write about your problem'
              ></textarea>
              <input
                type='submit'
                className='btn btn-secondary p-3 mt-2 w-100'
                value='Send Message'
              />
            </form>
          </div>
        </div>
      </div>
    </section>
  );
};

export default Contact;
