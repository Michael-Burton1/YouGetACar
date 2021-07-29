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
  findMostCommonNumbers = () => {
    let numDict = {
      1: 0,
      2: 0,
      3: 0,
      4: 0,
      5: 0,
      6: 0,
      7: 0,
      8: 0,
      9: 0,
      10: 0,
      11: 0,
      12: 0,
      13: 0,
      14: 0,
      15: 0,
      16: 0,
      17: 0,
      18: 0,
      19: 0,
      20: 0,
      21: 0,
      22: 0,
      23: 0,
      24: 0,
      25: 0,
      26: 0,
      27: 0,
      28: 0,
      29: 0,
      30: 0,
      31: 0,
      32: 0,
      33: 0,
      34: 0,
      35: 0,
      36: 0,
      37: 0,
      38: 0,
      39: 0,
      40: 0,
      41: 0,
      42: 0,
      43: 0,
      44: 0,
      45: 0,
      46: 0,
      47: 0,
      48: 0,
      49: 0,
      50: 0,
      51: 0,
      52: 0,
      53: 0,
      54: 0,
      55: 0,
      56: 0,
      57: 0,
      58: 0,
      59: 0,
      60: 0,
      61: 0,
      62: 0,
      63: 0,
      64: 0,
      65: 0,
      66: 0,
      67: 0,
      68: 0,
      69: 0,

    };
    let kickDict = {
      1: 0,
      2: 0,
      3: 0,
      4: 0,
      5: 0,
      6: 0,
      7: 0,
      8: 0,
      9: 0,
      10: 0,
      11: 0,
      12: 0,
      13: 0,
      14: 0,
      15: 0,
      16: 0,
      17: 0,
      18: 0,
      19: 0,
      20: 0,
      21: 0,
      22: 0,
      23: 0,
      24: 0,
      25: 0,
      26: 0,
      27: 0,
      28: 0,
    };
    for (i = 0; i <= 120; i++) {

    }
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
