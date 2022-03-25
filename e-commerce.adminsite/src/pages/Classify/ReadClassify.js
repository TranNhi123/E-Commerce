import React from "react";

function ReadClassify({ item, handleEditClick }) {
  return (
    <tr>
      <th scope="row">{item.iD_phan_loai}</th>
      <td>{item.ten_phan_loai}</td>
      <td>
        <button
          type="button"
          className="btn-edit"
          onClick={(event) => handleEditClick(event, item.iD_phan_loai)}
        >
          Edit
        </button>
      </td>
    </tr>
  );
}

export default ReadClassify;