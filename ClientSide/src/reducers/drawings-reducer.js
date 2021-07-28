import * as c from '../actions/ActionTypes';

let initialState = {
  isLoading: false,
  drawings: [],
  error: null
}

export default (state = initialState, action) => {
  switch (action.type) {
    case c.REQUEST_DRAWINGS:
      return Object.assign({}, state, {
        isLoading: true
      });
    case c.GET_DRAWINGS_SUCCESS:
      return Object.assign({}, state, {
        isLoading: false,
        drawings: action.drawings
      });
    case c.GET_DRAWINGS_FAILURE:
      return Object.assign({}, state, {
        isLoading: false,
        error: action.error
      });
    default:
      return state;
  }
};

