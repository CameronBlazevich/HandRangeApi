import React from "react";
import Hand from "./hand";
import { CardArray } from "../../common/cardArray";

function HandGridRow(props) {
  //console.log(props)
  const row = CardArray.map((card, index) => (
    <Hand
      key={index}
      column={index}
      row={props.row}
      columnCard={card}
      rowCard={props.rowCard}
      selectedHands={props.selectedHands}
      highlighted={props.highlighted}
    />
  ));
  return <div className="row">{row}</div>;
}

export default HandGridRow;