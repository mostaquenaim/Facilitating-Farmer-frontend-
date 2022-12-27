const Logout = () => {
  localStorage.removeItem('Bearer');
  localStorage.removeItem('User');
  window.location.href = '/';
};

export default Logout;
