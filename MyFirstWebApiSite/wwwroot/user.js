
//function newUser() {
// document.getElementById("divNewU").style.display="block";
//}
//function register() {
//    let user = {
//        email: document.getElementById("email").value,
//        fName: document.getElementById("fName").value,
//        lName: document.getElementById("lName").value,
//        password: document.getElementById("psw").value
//    }
    

//    let x = fetch("api/user",
//        {
//            method: 'POST',
//            headers: { 'content-type': 'application/json' },
//            body: JSON.stringify(user)
//        })
//        .then(response => response.json())
//        .then((data) => {
//            if (data.email == document.getElementById("email").value)
//                alert("Hi to  " + data.fName + " newww !!!!")
//            else
//                alert("not valid");
                
//        })
//        .catch(error => alert("catch"));
//}
//function logIn() {
//     let email= document.getElementById("em").value
//     let password= document.getElementById("ps").value
    
//    let x = fetch("api/user/" + email + "/" + password)
//        .then(response => response.json())
//        .then((data) => {
//            sessionStorage.setItem('user', JSON.stringify(data));
//            window.location.href = "enterUser.html";
//        })
//        .catch(error => alert("catch"));
//}
   

   