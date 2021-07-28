import * as c from './ActionTypes';

export const requestDrawings = () => ({
  type: c.REQUEST_DRAWINGS
});

export const getDrawingsSuccess = (drawings) => ({
  type: c.GET_DRAWINGS_SUCCESS,
  drawings
});

export const getDrawingsFailure = (error) => ({
  type: c.GET_DRAWINGS_FAILURE,
  error
});

export const makeApiCall = () => {
  return dispatch => {
    dispatch(requestDrawings);
    return fetch(`https://localhost:5051/api/Drawings`)
      .then(response => response.json())
      .then(
        (jsonifiedResponse) => {
          dispatch(getDrawingsSuccess(jsonifiedResponse));
        })
      .catch((error) => {
        dispatch(getDrawingsFailure(error));
      });
  }
}