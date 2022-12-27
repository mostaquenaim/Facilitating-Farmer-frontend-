import axios from 'axios';

// -----------------------------------------------------------------------------------
//
// ------------------------------ User Login  ----------------------------------------
//
// -----------------------------------------------------------------------------------

export const loginUser = async (e) => {
  try {
    e.preventDefault();
    const CurrentUser = document.querySelector('.loginAs').value;
    const Username = document.querySelector('.username').value;
    const Password = document.querySelector('.password').value;
    const URL = process.env.REACT_APP_Backend_URL;

    switch (CurrentUser) {
      case 'Specialist':
        var response = await axios.post(
          `${URL}/api/specialistLogin`,
          {
            Username,
            Password,
          }
        );
        localStorage.setItem('Bearer', response.data.TokenKey);
        localStorage.setItem('User', 'Specialist');
        window.location.href = '';
        break;
      default:
        var resp = await axios.post(`${URL}/api/customerLogin`, {
          Username,
          Password,
        });
        localStorage.setItem('Bearer', resp.data.TokenKey);
        localStorage.setItem('User', 'Customer');
        window.location.href = '';
        break;
    }
  } catch (error) {
    const MsgBox = document.querySelector('.signup-msg-box');
    MsgBox.style.backgroundColor = '#E64848';
    MsgBox.textContent = 'Unable to login. Please try again later.';
    MsgBox.style.color = '#FEFCF3';
    MsgBox.classList.remove('d-none');
    console.log(error);
  }
};

// -----------------------------------------------------------------------------------
//
// ------------------------------ Changes user type ----------------------------------
//
// -----------------------------------------------------------------------------------

export const selectLoginUser = (user) => {
  const currentUser = document.querySelector('.loginAs');
  switch (user) {
    case 'cus':
      currentUser.value = 'Customer';
      break;
    case 'sp':
      currentUser.value = 'Specialist';
      break;
    default:
      currentUser.value = 'Customer';
  }
};

// -----------------------------------------------------------------------------------
//
// ---------------------------------- User signup ------------------------------------
//
// -----------------------------------------------------------------------------------

export const signUpUser = async (e) => {
  try {
    e.preventDefault();
    const CurrentUser = document.querySelector('.loginAs').value;
    const Name = document.querySelector('.name').value;
    const Username = document.querySelector('.username').value;
    const Email = document.querySelector('.email').value;
    const Password = document.querySelector('.password').value;
    const URL = process.env.REACT_APP_Backend_URL;
    const MsgBox = document.querySelector('.signup-msg-box');

    switch (CurrentUser) {
      case 'Specialist':
        await axios.post(`${URL}/api/specialist/add`, {
          Name,
          Username,
          Email,
          Password,
        });
        MsgBox.style.backgroundColor = '#557571';
        MsgBox.textContent =
          'Specialist added successfully, wait for verification mail.';
        MsgBox.style.color = '#FEFCF3';
        MsgBox.classList.remove('d-none');
        break;
      default:
        await axios.post(`${URL}/api/customer/add`, {
          Name,
          Username,
          Email,
          Password,
        });
        MsgBox.style.backgroundColor = '#557571';
        MsgBox.textContent =
          'Customer added successfully, wait for verification mail.';
        MsgBox.style.color = '#FEFCF3';
        MsgBox.classList.remove('d-none');
        break;
    }
  } catch (error) {
    const MsgBox = document.querySelector('.signup-msg-box');
    MsgBox.style.backgroundColor = '#E64848';

    MsgBox.textContent = 'Unable to add user. Please try again later.';
    MsgBox.style.color = '#FEFCF3';
    MsgBox.classList.remove('d-none');
    console.log(error);
  }
};
