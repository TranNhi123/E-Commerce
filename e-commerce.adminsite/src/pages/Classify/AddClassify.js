import axios from "axios";
import React from "react";
import { createRef } from "react";

function AddNewSupplier({handleCancelAdd}) {
  const name = createRef();

  const addNewSupp = () => {
    axios
      .post(
        "https://localhost:7165/api/Classifies",
        {
          ten_phan_loai: name.current.value,
        }
      )
      .then(() => {
        alert("Add new succesful");
        window.location.reload();
      });
  };
  return (
    <div className="form-horizontal" style={{width: "659px"}}>
      <div style={{ display: "flex" }}>
        <div className="form-group" style={{ marginRight: "42px" }}>
          <label className="control-label col-sm-2">Name</label>
          <div className="col-sm-15">
            <input type="text" className="form-control" ref={name} />
          </div>
        </div>
      </div>
      <div style={{float: "right", marginBottom: "20px", marginRight: "0"}}>
        <button onClick={() => addNewSupp()} className="btn-add" style={{width: "120px"}}>
          Add New
        </button>
        <button onClick={handleCancelAdd} className="btn-delete" style={{width: "120px", marginRight: "0"}}>
          Cancel
        </button>
      </div>
    </div>
  );
}

export default AddNewSupplier;
