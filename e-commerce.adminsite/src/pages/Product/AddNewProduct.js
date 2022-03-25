/* eslint-disable react/no-direct-mutation-state */
import React, { createRef } from "react";
import { BiPlusMedical } from "react-icons/bi";
import Select from "react-select";
import axios from "axios";


class Product extends React.Component {
  constructor() {
    super();
    this.state = {
      showModal: false,
      idClassi: 0,
      lstClassify: [],
      selectedOption: 0,
    };
    this.getListClassify();
    this.nameProduct = createRef();
    this.amount = createRef();
    this.importPrice = createRef();
    this.exportPrice = createRef();
    this.descript = createRef();
    this.introduce = createRef();
    this.images = createRef();
  }

  changeIdClassi = (e) => {
    this.setState({ idClassi: e.value });
  };

  getListClassify = () => {
    axios
      .get("https://localhost:7165/api/Classifies")
      .then((res) => {
        res.data.forEach((element) => {
          this.state.lstClassify.push({
            value: element.iD_phan_loai,
            label: element.ten_phan_loai,
          });
        });
        this.setState(this);
      });
  };
  
  createProduct = () => {
    axios
      .post(
        "https://localhost:7165/api/Medicines",
        {
            ten_thc: this.nameProduct.current.value,
            sl_ton: this.amount.current.value,
            gia_nhap: this.importPrice.current.value,
            gia_ban: this.exportPrice.current.value,
            mo_ta: this.descript.current.value,
            gioi_thieu: this.introduce.current.value,
            hinh_anh: this.images.current.value,
            ClassifysID_phan_loai: parseInt(window.sessionStorage.getItem("iD_phan_loai")),
        }
      )
      .then((res) => {
        console.log(res.data);
        //this.props.history.push("/");
        alert("Add data successful");
      });
  };
  openModal = () => {
    this.setState({ showModal: true });
  };
  hideModal = () => {
    this.setState({ showModal: false });
  };

  render() {
    return (
      <>
        <div className="header">
          <h1>Add New Medicine</h1>
        </div>
        <div className="form-horizontal">
          {/* Name */}
          <div className="form-group">
            <label className="control-label col-sm-2">Name</label>
            <div className="col-sm-10">
              <input
                type="text"
                className="form-control"
                placeholder="Enter product’s name "
                ref={this.nameProduct}
                autoFocus
              />
            </div>
          </div>
          {/* Amount and Date */}
          <div style={{ display: "flex" }}>
            <div className="form-group" style={{ width: "300px" }}>
              <label className="control-label col-sm-2">Amount</label>
              <div className="col-sm-10">
                <input
                  type="number"
                  className="form-control"
                  placeholder="Enter the munber of products "
                  ref={this.amount}
                  min="1"
                  max="200"
                />
              </div>
            </div>
          </div>
          {/* Price */}
          <div style={{ display: "flex" }}>
            <div className="form-group" style={{ width: "200px" }}>
              <label className="control-label col-sm-2">Price</label>
              <div className="col-sm-10" style={{ display: "flex" }}>
                <div className="input-group-addon css-number-2">
                  <span style={{ fontSize: "18px" }}>$</span>
                </div>
                <input
                  style={{ marginLeft: "-1px" }}
                  type="number"
                  className="form-control price"
                  placeholder="Import Price"
                  ref={this.importPrice}
                  min="1.000"
                  max="3.000.000"
                />
              </div>
            </div>
            <div className="form-group" style={{ width: "200px" }}>
              <label className="control-label col-sm-2"></label>
              <div className="col-sm-10" style={{ display: "flex" }}>
                <div className="input-group-addon css-number-2">
                  <span style={{ fontSize: "18px" }}>$</span>
                </div>
                <input
                  style={{ marginLeft: "-1px" }}
                  type="number"
                  class="form-control price"
                  placeholder="Export Price"
                  ref={this.exportPrice}
                  min="1000"
                  step="1.000"
                  max="3.000.000"
                />
              </div>
            </div>
          </div>
          {/* Classify */}
          <div style={{ display: "flex" }}>
            <div className="form-group" style={{ width: "367px" }}>
              <label className="control-label col-sm-10">
                Classification of Item
              </label>
              <div className="col-sm-10">
                <Select
                  options={this.state.lstClassify}
                  onChange={this.changeIdClassi}
                  value={this.state.lstClassify.find(
                    (id) => id.value === this.state.idClassi
                  )}
                />
                {window.sessionStorage.setItem(
                  "iD_phan_loai",
                  this.state.idClassi
                )}
              </div>
            </div>
          </div>
          {/* Description */}
          <div className="form-group">
            <label className="control-label col-sm-2">Description</label>
            <div className="col-sm-10">
              <textarea
                style={{ height: "186px", resize: "none" }}
                type="text"
                className="form-control"
                placeholder="Enter a Description"
                ref={this.descript}
              />
            </div>
          </div>
          {/* Introduce */}
          <div className="form-group">
            <label className="control-label col-sm-2">Introduce</label>
            <div className="col-sm-10">
              <textarea
                style={{ height: "186px", resize: "none" }}
                type="text"
                className="form-control"
                placeholder="Enter a Description"
                ref={this.introduce}
              />
            </div>
          </div>
          {/* Image */}
          <div className="form-group">
            <label className="control-label col-sm-2">Image</label>
            <div className="col-sm-10">
              <input
                type="text"
                className="form-control"
                placeholder="Enter image's link"
                ref={this.images}
                autoFocus
              />
            </div>
          </div>
          <div className="form-group">
            <button className="btn-add" onClick={this.createProduct}>
              Save
            </button>
            <button className="btn-edit">Edit</button>
          </div>
        </div>
      </>
    );
  }
}

export default Product;
