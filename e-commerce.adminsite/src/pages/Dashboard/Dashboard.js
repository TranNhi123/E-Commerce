import axios from "axios";
import React, { useState, useEffect } from "react";
import { Link } from "react-router-dom";
import ProductView from "../Product/ProductView"
import { BiPlusMedical } from "react-icons/bi";

function Dashboard() {
  const [products, setProducts] = useState([]);
  const [modalShow, setModalShow] = useState(false);
  const [name, setName] = useState("");
  const [introduce, setIntroduce] =useState("");
  const [decripsion, setDecripsion] =useState("");
  const [amount, setAmount] =useState("");
  const [importprice, setImportprice] =useState("");
  const [exportprice, setExportprice] =useState("");
  const [image, setImage] =useState("");

  useEffect(() => {
    const getAllPd = async () => {
        const data = await axios.get(
          "https://localhost:7165/api/Medicines"
        );
        setProducts(data.data);
    };
    getAllPd();
  }, []);

  const onDelete = (id) => {
    axios.delete(`https://localhost:7165/api/Medicines/${id}`)
    .then(() => window.location.reload())
  }
  return (
    <>
      <div className="hearder">
        <h1>MEDICINE</h1>
        <div className="btn">
          <button className="btn-add">
            <Link
              to="/AddNewProduct"
              style={{
                textDecoration: "none",
                color: "white",
                wordBreak: "break-word",
                overflow: "hidden",
              }}
            >
              <BiPlusMedical />
              <span>Add New Staff</span>
            </Link>
          </button>
        </div>
      </div>

      <table
        className="table table-hover"
        style={{ backgroundColor: "#fff", width: "985px" }}
      >
        <thead>
          <tr>
            <th scope="col" style={{ textAlign: "center" }}>Name</th>
            <th scope="col" style={{ textAlign: "center" }}>Classify</th>
            <th scope="col" style={{ textAlign: "center" }}>Action</th>
          </tr>
        </thead>
        <tbody>
          {products.length !== 0
            ? products.map((item, index) => (
                <tr key={index}>
                  <td>{item.ten_thc}</td>
                  <td>{item.classifys.ten_phan_loai}</td>
                  <td style={{ textAlign: "center" }}>
                    <button
                      className="btn-view"
                      onClick={() => {
                        setModalShow(true);
                        setName(item.ten_thc);
                        setIntroduce(item.gioi_thieu);
                        setDecripsion(item.mo_ta);
                        setAmount(item.sl_ton);
                        setImportprice(item.gia_nhap);
                        setExportprice(item.gia_ban);
                        setImage(item.hinh_anh);
                      }}
                    >
                      View
                    </button>
                    <Link to={"/products/edit/" + item.id_thc}>
                      <button className="btn-edit">Edit</button>
                    </Link>
                    <button className="btn-delete" onClick={() => onDelete(item.id_thc)}>Delete</button>
                  </td>
                </tr>
              ))
            : null}
        </tbody>
      </table>
      {modalShow ? (
        <ProductView
          show={modalShow}
          onHide={() => setModalShow(false)}
          name={name}
          introduce={introduce}
          decripsion={decripsion}
          amount={amount}
          importprice={importprice}
          exportprice={exportprice}
          image={image}
        />
      ) : null}
    </>
  );
}

export default Dashboard;
