import Contact from './Contact';
import HeroSection from './HeroSection';
import Reviews from './ReviewSection';
import Services from './Services';
import Navbar from '../Navbar/Index';

const Home = () => {
  return (
    <>
      <Navbar></Navbar>
      <HeroSection />
      <Services />
      <Reviews />
      <Contact />
    </>
  );
};

export default Home;
