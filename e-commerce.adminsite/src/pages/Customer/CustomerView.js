import { Modal, Button } from "react-bootstrap";
function CustomerView(props) {
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
            Customer Info
          </Modal.Title>
        </Modal.Header>
        <Modal.Body>
          <div>
            <div>Customer's Name: {props.name}</div>
            <div>Email: {props.email}</div>
            <div>Phone Number: {props.phone}</div>
            <div>Address: {props.address}</div>
            <div>
              Birthday: {props.date}
            </div>
          </div>
        </Modal.Body>
        <Modal.Footer>
          <Button onClick={props.onHide}>Close</Button>
        </Modal.Footer>
      </Modal>
    </>
  );
}

export default CustomerView;
