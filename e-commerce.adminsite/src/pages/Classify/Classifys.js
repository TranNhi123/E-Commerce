import axios from "axios";
import React, { Fragment } from "react";
import { useState } from "react";
import { useEffect } from "react";
import EditClassify from "./EditClassify";
import AddClassify from "./AddClassify";
import ReadClassify from "./ReadClassify";
import { BiPlusMedical } from "react-icons/bi";

function Classifys() {
    const [classify, setClassify] = useState([]);
    const [editId, setEditId] = useState(null);
    const [change, setChange] = useState(false);

    const handleEditClick = (event, types) => {
        event.preventDefault();
        setEditId(types);
      };
      const handleCancelClick = () => {
        setEditId(null);
      };
      const handleCancelAdd = () => {
        setChange(false);
      }
      useEffect(() => {
        axios
          .get("https://localhost:7165/api/Classifies")
          .then((res) => {
            setClassify(res.data);
          });
      }, []);

    return (
        <>
            <div className="hearder">
            <h1>Classify</h1>
            {change ? (
            <AddClassify handleCancelAdd={handleCancelAdd}/>
            ) : (
            <div className="btn">
                <button className="btn-add" onClick={() => setChange(true)}>
                <BiPlusMedical />
                <span>Add Classify</span>
                </button>
            </div>
            )}
        </div>

        <table className="table table-hover" style={{ backgroundColor: "#FFF" }}>
            <thead>
            <tr>
                <th scope="col">ID</th>
                <th scope="col">Name</th>
            </tr>
            </thead>
            <tbody>
            {classify.map((item) => (
                <Fragment>
                {editId === item.iD_phan_loai ? (
                    <EditClassify
                    item={item}
                    handleCancelClick={handleCancelClick}
                    />
                ) : (
                    <ReadClassify
                    item={item}
                    handleEditClick={handleEditClick}
                    />
                )}
                </Fragment>
            ))}
            </tbody>
        </table>
        </>
    );
}
export default Classifys;