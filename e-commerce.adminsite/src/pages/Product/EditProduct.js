/* eslint-disable react-hooks/exhaustive-deps */
import React, { useState } from "react";
import axios from "axios";
import { useNavigate } from "react-router-dom";
import { useEffect } from "react";
import EditProductlayout from "./EditProductlayout";

function EditStaff(props) {
  const idProduct = window.location.pathname.substring(15);
  const [name, setName] = useState("");
  const [introduce, setIntroduce] =useState("");
  const [decripsion, setDecripsion] =useState("");
  const [amount, setAmount] =useState("");
  const [importprice, setImportprice] =useState("");
  const [exportprice, setExportprice] =useState("");
  const [image, setImage] =useState("");
  const [classify, setClassify] =useState("");
  let navigate = useNavigate();

  const nameHandler = (e) => {
    setName(e.target.value);
  };
  const introduceHandler = (e) => {
    setIntroduce(e.target.value);
  };
  const decripsionHandler = (e) => {
    setDecripsion(e.target.value);
  };
  const amountHandler = (e) => {
    setAmount(e.target.value);
  };
  const importpriceHandler = (e) => {
    setImportprice(e.target.value);
  };
  const exportpriceHandler = (e) => {
    setExportprice(e.target.value);
  };
  const imageHandler = (e) => {
    setImage(e.target.value);
  };
  const classifyHandler = (e) => {
    setClassify (e.target.value);
  };
  useEffect(() => {
    axios
      .get(`https://localhost:7165/api/Medicines/${idProduct}`)
      .then((res) => {
        setName(res.data.ten_thc);
        setIntroduce(res.data.gioi_thieu);
        setDecripsion(res.data.mo_ta);
        setAmount(res.data.sl_ton);
        setImportprice(res.data.gia_nhap);
        setExportprice(res.data.gia_ban);
        setImage(res.data.hinh_anh);
        setClassify(res.data.classifysID_phan_loai)
      });
  }, []);
  const editProduct = (id) => {
    axios
      .put(`https://localhost:7165/api/Medicines/${id}`, {
        id_thc: idProduct,
        ten_thc: name,
        gioi_thieu: introduce,
        mo_ta: decripsion,
        sl_ton: amount,
        gia_nhap: importprice,
        gia_ban: exportprice,
        hinh_anh: image,
        classifysID_phan_loai: classify,
      })
      .then(() => {
        alert("add successfull");
        navigate("/");
      });
  };

  return (
    <>
      <EditProductlayout
        name={name}
        introduce={introduce}
        decripsion={decripsion}
        amount={amount}
        importprice={importprice}
        exportprice={exportprice}
        image={image}
        classify={classify}
        nameHandler={nameHandler}
        introduceHandler={introduceHandler}
        decripsionHandler={decripsionHandler}
        amountHandler={amountHandler}
        importpriceHandler={importpriceHandler}
        exportpriceHandler={exportpriceHandler}
        imageHandler={imageHandler}
        classifyHandler={classifyHandler}
        editProduct={() => editProduct(idProduct)}
      />
    </>
  );
}

export default EditStaff;
