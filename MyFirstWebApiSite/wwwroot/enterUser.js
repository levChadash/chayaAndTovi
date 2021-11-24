////let email=  JSON.parse(sessionStorage.getItem('user')).email
////document.getElementById("email").value = email;
////let password = JSON.parse(sessionStorage.getItem('user')).password
////document.getElementById("psw").value = password;
////let fName = JSON.parse(sessionStorage.getItem('user')).fName
////document.getElementById("fName").value = fName;
////let lName = JSON.parse(sessionStorage.getItem('user')).lName
////document.getElementById("lName").value = lName;
////function update(){
////    let user = {
////        id:JSON.parse(sessionStorage.getItem('user')).id,
////        email: document.getElementById("email").value,
////        fName: document.getElementById("fName").value,
////        lName: document.getElementById("lName").value,
////        password: document.getElementById("psw").value
////    }
////    let x = fetch("api/user/"+user.id,
////        {
////            method: 'PUT',
////            headers: { 'content-type': 'application/json' },
////            body: JSON.stringify(user)
////        })
////        .then(response => {
////            if (response.ok)
////              alert("Hi to  " + user.fName + "update !!!!")
////            else
////                throw new Error(response.status)
////        })
////        .catch(error => alert(error));
////}