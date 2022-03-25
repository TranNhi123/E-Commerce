/* eslint-disable eqeqeq */
import axios from "axios";
import React, { useState, useEffect } from "react";
import CustomerView from "./CustomerView";

function Customers() {
  const [customers, setCustomers] = useState([]);
  const [modalShow, setModalShow] = useState(false);
  const [name, setName] = useState("");
  const [email, setEmail] = useState("");
  const [phone, setPhone] = useState("");
  const [address, setAddress] = useState("");
  const [date,setDate] = useState("")
  //const [array, setArray] = useState([])

  useEffect(() => {
    const getAllCustomer = async () => {
        const data = await axios.get("https://localhost:7165/api/Customers");
        setCustomers(data.data);
        console.log(data.data.SDT)
    };
    getAllCustomer();
    
  }, []);

  return (
    <>
      <h1>Customers</h1>
      <table className="table table-hover" style={{ backgroundColor: "#fff" }}>
        <thead>
          <tr>
            <th scope="col">Customer's Name</th>
            <th scope="col">Email</th>
            <th scope="col">Phone</th>
            <th scope="col">Address</th>
            <th scope="col">Birthday</th>
            <th scope="col" style={{ width: "200px", textAlign: "center" }}>
              Action
            </th>
          </tr>
        </thead>
        <tbody>
          {customers.length !== 0
            ? customers.map((item, index) => (
                <tr key={index}>
                  <td>{item.ten_KH}</td>
                  <td>{item.email}</td>
                  <td style={{ width: "164px" }}>
                    {item.sdt}
                  </td>
                  <td style={{ width: "164px" }}>
                    {item.dia_chi}
                  </td>
                  <td style={{ textAlign: "end", width: "164px" }}>
                    {item.ngay_sinh}
                  </td>
                  <td style={{ width: "200px", textAlign: "center" }}>
                    <button
                      className="btn-view"
                      onClick={() => {
                        setModalShow(true);
                        setName(item.ten_KH);
                        setEmail(item.email);
                        setPhone(item.sdt);
                        setAddress(item.dia_chi);
                        setDate(item.ngay_sinh);
                      }}
                    >
                      View
                    </button>
                  </td>
                </tr>
              ))
            : null}
        </tbody>
      </table>
      {modalShow ? (
        <CustomerView
          show={modalShow}
          onHide={() => setModalShow(false)}
          name={name}
          email={email}
          phone={phone}
          address={address}
          date={date}
        />
      ) : null}
    </>
  );
}

export default Customers;
