import axios from 'axios';
import { useEffect, useState } from 'react';
import { Link } from 'react-router-dom';

const ViewAll = () => {
  const [courses, setCourses] = useState([]);
  useEffect(() => {
    axios
      .get(`${process.env.REACT_APP_Backend_URL}/api/course/all`)
      .then((course) => {
        console.log(course);
        setCourses(course.data);
      })
      .catch((err) => {
        console.log(err);
      });
  });

  // alert(courses.data[0].Difficulty.Type);
  var data = (
    <table className='table table-success table-hover'>
      <thead>
        <tr>
          <th scope='col'>Title</th>
          <th scope='col'>Subtitle</th>
          <th scope='col'>Description</th>
          <th scope='col'>LastUpdatedAt</th>
          <th scope='col'>Difficulty</th>
          <th scope='col'>Category</th>
          <th scope='col'></th>
        </tr>
      </thead>
      <tbody>
        {courses.map((course) => {
          return (
            <tr key={courses.Id}>
              <td>{course.Title}</td>
              <td>{course.Subtitle}</td>
              <td>{course.Description}</td>
              <td>{course.LastUpdatedAt}</td>
              <td>{course.Difficulty.Type}</td>
              <td>{course.Category.Type}</td>
              <td>
                <Link to="/course/">View course</Link>
              </td>
            </tr>
          );
        })}
      </tbody>
    </table>
  );
  return data;
};

export default ViewAll;
