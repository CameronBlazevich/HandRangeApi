import { apiBaseUrl } from "../common/apiConstants";

class HandRangeApi {
  static getHandRanges(authBearer) {
    var request = new Request(apiBaseUrl + "handRanges/", {
      headers: {
        Authorization: authBearer,
      },
      method: "GET",
    });
    return fetch(request).then((response) => response.json());
  }

  static getHandRange(authBearer, positionId) {
    var request = new Request(apiBaseUrl + `handranges/${positionId}`, {
      headers: {
        Authorization: authBearer,
      },
      method: "GET",
    });
    return fetch(request).then((response) => response.json());
  }

  static updateHandRange(positionKey, hands, authBearer) {
    var request = new Request(apiBaseUrl + "handRanges/", {
      headers: {
        Accept: "application/json",
        "Content-Type": "application/json",
        Authorization: authBearer,
      },
      method: "POST",
      body: JSON.stringify({
        positionKey,
        hands,
      }),
    });

    return fetch(request).then((response) => response.json());
  }

  static updateFormattedHandRange(positionKey, raisingRange, flattingRange, authBearer) {
    const request = new Request(apiBaseUrl + "formattedRange/", {
      headers: {
        Accept: "application/json",
        "Content-Type": "application/json",
        Authorization: authBearer,
      },
      method: "POST",
      body: JSON.stringify({
        positionKey,
        Ranges: [
          {ActionType: "Raise", FormattedHandRange: raisingRange},
          {ActionType: "Call", FormattedHandRange: flattingRange}
        ],
      }),
    });

    return fetch(request).then((response) => response.json());
  }
}

export default HandRangeApi;