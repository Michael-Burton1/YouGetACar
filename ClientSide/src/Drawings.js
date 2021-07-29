import React from 'react';
import { connect } from 'react-redux';
import { makeApiCall } from './actions';

class Drawings extends React.Component {
  constructor(props) {
    super(props);
  }

  componentDidMount() {
    const { dispatch } = this.props;
    dispatch(makeApiCall());
  }

  // findMostCommonNumbers = (data) => { logic here to find those, return the new array or whatever data type}
  // Look at dictionaries (JS named something else) key,values. 
  // Make some conditional that looks at the number being passed in, checks to see if that number exists in the dictionary -- if it does, add 1 to the value (number would be key, value would be occurences) and if it does NOT exist, add a new key and value of 1 (one occurence so far)
  // after all that, check to see which top x numbers have the highest value, and return them.

  // theMethodthatIsCalledWhenClicked = () => 

  render() {
    const { error, isLoading, drawings } = this.props;
    if (error) {
      return <React.Fragment>Error: {error.message}</React.Fragment>;
    } else if (isLoading) {
      return <React.Fragment>Loading...</React.Fragment>;
    } else {
      return (
        <React.Fragment>
          <h1>All drawing numbers</h1>
          {console.log(drawings)};
          <ul>
            {drawings.map((drawing, index) =>
              <li key={index}>
                <h3>{drawing.name}: {drawing.date}</h3>
                <h4>Winning numbers: {drawing.num1},{drawing.num2},{drawing.num3},{drawing.num4},{drawing.num5} <br></br>PowerBall: {drawing.kicker}</h4>
              </li>
            )}
          </ul>
          {/* <button onClick={call that method here} />*/}
        </React.Fragment>
      );
    }
  }
}

const mapStateToProps = state => {
  return {
    drawings: state.drawings,
    isLoading: state.isLoading,
    error: state.error
  }
}

export default connect(mapStateToProps)(Drawings);
