import * as utils from './utils';
import Navbar from '../Navbar/Index';

const Signup = () => {
  return (
    <>
      <Navbar />
      <div className='container min-vh-100'>
        <div className='row'>
          <h4 className='p-2 text-center d-none signup-msg-box'>Message box</h4>
        </div>
        <div className='row'>
          <div
            className='col-lg-6 d-flex align-items-center justify-content-center'
            style={{ height: '80vh' }}
          >
            <div>
              <h3 className='text-center'>Sign up as</h3>
              <button
                className='btn btn-secondary w-100 p-3'
                onClick={(e) => utils.selectLoginUser('cus')}
              >
                Customer
              </button>
              <button
                className='btn btn-secondary w-100 p-3 mt-2'
                onClick={(e) => utils.selectLoginUser('sp')}
              >
                Specialist
              </button>
            </div>
          </div>

          <div
            className='col-lg-6 d-flex align-items-center justify-content-center'
            style={{ height: '80vh' }}
          >
            <form action='' method='post'>
              <input
                type='text'
                name='loginAs'
                className='loginAs w-100 p-2'
                value={'Customer'}
                disabled
              />

              <input
                type='text'
                name='name'
                className='name p-3 w-100 mt-2'
                placeholder='Enter your name'
              />

              <input
                type='text'
                name='username'
                className='username p-3 w-100 mt-2'
                placeholder='Enter your username'
              />

              <input
                type='text'
                name='email'
                className='email p-3 w-100 mt-2'
                placeholder='Enter your email'
              />

              <input
                type='password'
                name='password'
                className='password p-3 w-100 mt-2 '
                placeholder='Enter your password'
              />
              <input
                type='submit'
                name='signup'
                className='signup p-3 w-100 mt-2 btn btn-primary'
                value={'Sign up'}
                onClick={(e) => utils.signUpUser(e)}
              />
            </form>
          </div>
        </div>
      </div>
    </>
  );
};

export default Signup;
