import React from 'react'

function EditProductlayout(props) {
  return (
    <>
      <h1>Edit Medicine</h1>
      {console.log(props.name)}
      <div className="form-wrapper">
        <table className="table-new-staff">
          <tr className="name">
            <td className="td-label">Name</td>
            <td className="td-input" style={{ paddingLeft: "10px" }}>
              <input className="text-field" type="text" value={props.name} onChange={props.nameHandler}/>
            </td>
          </tr>
          <tr className="name">
            <td className="td-label">introduce</td>
            <td className="td-input" style={{ paddingLeft: "10px" }}>
              <input className="text-field" type="text" value={props.introduce} onChange={props.introduceHandler}/>
            </td>
          </tr>
          <tr className="name">
            <td className="td-label">decripsion</td>
            <td className="td-input" style={{ paddingLeft: "10px" }}>
              <input className="text-field" type="text" value={props.decripsion}  onChange={props.decripsionHandler}/>
            </td>
          </tr>
          <tr className="phone">
            <td className="td-label">amount</td>
            <td className="td-input" style={{ paddingLeft: "10px" }}>
              <input className="text-field" type="number" value={props.amount} onChange={props.amountHandler}/>
            </td>
          </tr>
          <tr className="address">
            <td className="td-label">Importprice</td>
            <td className="td-input" style={{ paddingLeft: "10px" }}>
              <input className="text-field" type="text" value={props.importprice} onChange={props.importpriceHandler}/>
            </td>
          </tr>
          <tr className="address">
            <td className="td-label">Exportprice</td>
            <td className="td-input" style={{ paddingLeft: "10px" }}>
              <input className="text-field" type="text" value={props.exportprice} onChange={props.exportpriceHandler}/>
            </td>
          </tr>
          <tr className="address">
            <td className="td-label">classify</td>
            <td className="td-input" style={{ paddingLeft: "10px" }}>
              <input className="text-field" type="text" value={props.classify} onChange={props.classifyHandler}/>
            </td>
          </tr>
          <tr className="address">
            <td className="td-label">image</td>
            <td className="td-input" style={{ paddingLeft: "10px" }}>
              <input className="text-field" type="text" value={props.image} onChange={props.imageHandler}/>
            </td>
          </tr>
          <tr className="btn">
            <td></td>
            <td>
              <button className="btn-add" onClick={props.editProduct}>
                Save change
              </button>
            </td>
          </tr>
        </table>
      </div>
    </>
  )
}

export default EditProductlayout
