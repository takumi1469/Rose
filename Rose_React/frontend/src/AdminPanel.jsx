import './AdminPanel.css'
import { useState, useEffect } from 'react'


function AdminPanel() {

    const [selectedFile, setSelectedFile] = useState(null);

    const handleFileChange = (event) => {
        const file = event.target.files[0];
        setSelectedFile(file);
    };

    const uploadFile = () => {
        const formData = new FormData();
        formData.append('csvFile', selectedFile);

        fetch('https://localhost:7242/api/ImportCsv', {
            method: 'POST',
            body: formData
        })
            .then(response => {
                if (response.ok) {
                    console.log("Upload successful");
                } else {
                    console.log("upload failed");
                }
            })
            .catch(error => {
                alert('Error occurred');
            });
    };


    return (
        <>
            <div className='div-choose-file'>
                <h2 className="text-3xl">Admin Panel</h2>
                <input
                    type="text"
                    value={selectedFile ? selectedFile.name : ''}
                    placeholder="File hasn't been chosen"
                    readOnly
                />
                <input type="file" className='hidden' id="input-file" onChange={handleFileChange}></input>
                <button id="button-choose-file" className="button-choose-file bg-blue-950 text-white" onClick={() => {
                    document.getElementById('input-file').click()
                }}>Choose file to upload</button>
            </div>
            <div className="div-upload-file">
                <button id="button-upload-file"
                    className="button-upload-file 
                bg-blue-950
                text-white
                ml-14
                mt-4"
                    onClick={uploadFile}>
                    Upload the file</button>
            </div>
        </>
    );
}













export default AdminPanel