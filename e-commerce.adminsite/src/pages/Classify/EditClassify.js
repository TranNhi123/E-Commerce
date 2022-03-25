import React, { useState } from "react";
import axios from "axios";
import { useEffect } from "react";

const EditableSupplier = ({ item, handleCancelClick }) => {
  const [name, setName] = useState("");

  useEffect(() => {
    setName(item.ten_phan_loai);
  }, []);
  const nameHandler = (e) => {
    setName(e.target.value);
  };
  const handleEditSubmit = (id) => {
    axios
      .put(`https://localhost:7165/api/Classifies/${id}`, {
        iD_phan_loai: item.iD_phan_loai,
        ten_phan_loai: name
      })
      .then(() => {
         window.location.reload();
      });
  };
  return (
    <tr>
      <th scope="row">{item.iD_phan_loai}</th>
      <td>
        <input
          type="text"
          required="required"
          value={name}
          onChange={nameHandler}
        />
      </td>
      <td>
        <button className="btn-edit" onClick={() => handleEditSubmit(item.iD_phan_loai)}>
          Save
        </button>
        <button className="btn-delete" onClick={handleCancelClick}>Cancel</button>
      </td>
    </tr>
  );
};

export default EditableSupplier;
