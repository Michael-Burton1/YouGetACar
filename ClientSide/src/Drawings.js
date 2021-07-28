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
                <h3>{drawing.name}</h3>
              </li>
            )}
          </ul>
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
