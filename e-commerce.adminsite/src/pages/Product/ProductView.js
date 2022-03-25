import React from "react";
import { Modal, Button } from "react-bootstrap";

function ProductView(props) {
  return (
    <>
      <Modal
        {...props}
        size="lg"
        aria-labelledby="contained-modal-title-vcenter"
        centered
      >
        <Modal.Header closeButton>
          <Modal.Title id="contained-modal-title-vcenter">
            Medicine Detail
          </Modal.Title>
        </Modal.Header>
        <Modal.Body>
          <table>
            <tr>
              <td>Name </td>
              <td style={{paddingLeft: "10px"}}><b>{props.name}</b></td>
            </tr>
            <tr>
              <td>Introduce</td>
              <td style={{paddingLeft: "10px"}}><b>{props.introduce}</b></td>
            </tr>
            <tr>
              <td>Decripsion</td>
              <td style={{paddingLeft: "10px"}}><b>{props.decripsion}</b></td>
            </tr>
            <tr>
              <td>Amount</td>
              <td style={{paddingLeft: "10px"}}><b>{props.amount}</b></td>
            </tr>
            <tr>
              <td>Importprice</td>
              <td style={{paddingLeft: "10px"}}><b>{props.importprice}</b></td>
            </tr>
            <tr>
              <td>Exportprice</td>
              <td style={{paddingLeft: "10px"}}><b>{props.exportprice}</b></td>
            </tr>
            <tr>
              <td>Image</td>
              <td style={{paddingLeft: "10px"}}><img src={props.image} style={{width: "350px"}}/></td>
            </tr>
          </table>
        </Modal.Body>
        <Modal.Footer>
          <Button onClick={props.onHide}>Close</Button>
        </Modal.Footer>
      </Modal>
    </>
  );
}

export default ProductView;
