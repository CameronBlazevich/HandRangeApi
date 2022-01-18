import * as ActionTypes from "../actions/actionTypes";
import initialState from "./initialState";

export default function modeReducer(state = initialState.mode, action) {
  switch (action.type) {
    case ActionTypes.MODE_CHANGED:
      return action.mode;

    default:
      return state;
  }
}
