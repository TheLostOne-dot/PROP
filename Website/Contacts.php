<?php
require_once "config.php";

 function register()
 {

     $firstname = "";
     $lastname = "";
     $email = "";
     $psw = "";
     $firstname_err = "";
     $lastname_err = "";
     $email_err = "";
     $psw_err = "";
     $confirm_password_err = "";
     global $link;

     if (empty(trim($_POST["firstname"]))) {
         $firstname_err = "Please enter your first name.";
     } else {
         $firstname = trim($_POST["firstname"]);
     }

     if (empty(trim($_POST["lastname"]))) {
         $lastname_err = "Please enter your last name.";
     } else {
         $lastname = trim($_POST["lastname"]);
     }

     do {
         function generateRandomString($length = 10)
         {
             $characters = '0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ';
             $charactersLength = strlen($characters);
             $randomString = '';
             for ($i = 0; $i < $length; $i++) {
                 $randomString .= $characters[rand(0, $charactersLength - 1)];
             }
             return $randomString;
         }

         $eventID = generateRandomString();
         $result = mysqli_query($link,"Select EventID From visitor Where EventID = '$eventID' ");
     } while (mysqli_num_rows($result) > 0);

if (empty(trim($_POST["email"]))) {
$email_err = "Please enter your e-mail address.";
} else {
$sql = mysqli_query($link, "Select Email From visitor Where Email = 'email'");
if (mysqli_num_rows($sql) > 0) {
$email_err = "This e-mail has already been used.";
} else {
$email = $_POST["email"];
}
}
if (empty(trim($_POST["psw"]))) {
$psw_err = "Please enter a password.";
} elseif (strlen(trim($_POST["psw"])) < 8) {
$psw_err = "Password must be at least 8 characters";
} else {
$psw = trim($_POST["psw"]);
}

if (empty(trim($_POST["psw-repeat"]))) {
$confirm_password_err = "Please confirm password.";
} else {
$confirm_password = trim($_POST["psw-repeat"]);
if (empty($psw_err) && ($psw != $confirm_password)) {
$confirm_password_err = "Passwords did not match.";
}
}

if (empty($firstname_err) && empty($lastname_err) && empty($email_err) && empty($psw_err) && empty($confirm_password_err)) {
$sql = "INSERT INTO visitor (EventID,Firstname,Lastname,Email,Password)
VALUES ('$eventID','$firstname','$lastname','$email','$psw')";
if($stmt=mysqli_prepare($link,$sql)) {
mysqli_stmt_bind_param($stmt, "sssss",$param_eventID,$param_firstname, $param_lastname,$param_email,$param_psw);
$param_eventID=$eventID;
$param_firstname=$firstname;
$param_lastname=$lastname;
$param_email=$email;
$param_psw=password_hash($psw,PASSWORD_DEFAULT);
if(mysqli_stmt_execute($stmt)){
header("location: index.php");
} else{
echo "Something went wrong. Please try again later.";
}
}
else{
echo "Something went wrong. Please try again later.";
}
mysqli_stmt_close($stmt);
}
else{
echo "Something went wrong with your registration.Please check all the fields.";
}
mysqli_close($link);
}
if ('POST' === $_SERVER['REQUEST_METHOD']) {
if (isset($_POST["register"])) {
register();
} else {
die("ERROR1");
}
}
?>

<html>
<head>
    <link rel="stylesheet" type="text/css" href="home.css">
</head>
<body>
    <header>
 <div class="navbar">
     <img src="mini%20logo.png" alt="logo" class="logo">
     <nav>
   <ul>
   <li><a href="index.php">Home</a></li>
    <li><a href="index.php#AboutUs">About us</a></li>
    <li><a href="Buy%20Tickets.php">Buy Tickets</a></li>
    <li><a href="Line-Up.php">Line-Up</a></li>
    <li><a href="index.php#EventInfo">Event Info</a></li>
    <li><a href="Contacts.php">Contacts</a></li>
    <li><a onclick="document.getElementById('id01').style.display='block'" style="width:auto;">Login</a></li>
    <li><a onclick="document.getElementById('id02').style.display='block'" style="width:auto;">Sign Up</a></li>
  </ul>
         <div id="id01" class="modal">

             <form class="modal-content animate" action="#">
                 <div class="imgcontainer">
                     <span onclick="document.getElementById('id01').style.display='none'" class="close" title="Close Modal">&times;</span>
                     <img src="loginicon.png" alt="Avatar" class="avatar">
                 </div>
                 <div class="container3">
                     <label for="email"><b>Email</b></label>
                     <input type="text" placeholder="Enter Email address" name="email" required>

                     <label for="psw"><b>Password</b></label>
                     <input type="password" placeholder="Enter Password" name="psw" required>

                     <button type="submit">Login</button>
                     <label>
                         <input type="checkbox" checked="checked" name="remember"> Remember me
                     </label>
                 </div>

                 <div class="container3" style="background-color:#f1f1f1">
                     <button type="button" onclick="document.getElementById('id01').style.display='none'" class="cancelbtn">Cancel</button>
                     <span class="psw">Forgot <a href="#">password?</a></span>
                 </div>
             </form>
         </div>
         <!-- Register-->
         <div id="id02" class="modal">
             <span onclick="document.getElementById('id02').style.display='none'" class="close" title="Close Modal">&times;</span>
             <form class="modal-content animate" action="index.php" method="post">
                 <div class="container3">
                     <h1>Sign Up</h1>
                     <p>Please fill in this form to create an account.</p>
                     <hr>
                     <label for="firstname"><b>First Name</b></label>
                     <input type="text" placeholder="First Name" name="firstname" required>

                     <label for="lastname"><b>Last Name</b></label>
                     <input type="text" placeholder="Last Name" name="lastname" required>

                     <label for="email"><b>Email</b></label>
                     <input type="text" placeholder="Enter Email" name="email" required>

                     <label for="psw"><b>Password</b></label>
                     <input type="password" placeholder="Enter Password" name="psw" required>

                     <label for="psw-repeat"><b>Repeat Password</b></label>
                     <input type="password" placeholder="Repeat Password" name="psw-repeat" required>

                     <label>
                         <input type="checkbox" checked="checked" name="remember" style="margin-bottom:15px"> Remember me
                     </label>

                     <p>By creating an account you agree to our <a href="#" style="color:dodgerblue">Terms & Privacy</a>.</p>

                     <div class="clearfix">
                         <button type="button" onclick="document.getElementById('id02').style.display='none'" class="cancelbtn">Cancel</button>
                         <button type="submit" class="signupbtn" name="register" >Sign Up</button>
                     </div>
                 </div>
             </form>
         </div>
     </nav>
    </div>
    </header>
    <div class="main">
    <h1>Contacts</h1>
        <p>Email: <a href="#">b.schouwenaars@fontys.nl</a></p>
        <p>Phone number:  +31885075375</p>
    </div>
    <footer>
        <div class="company">
            <ul>
            <li><h3>Company address</h3>Rachelsmolen 1, 5612 MA Eindhoven</li>
            <li><h3>Contacts</h3>+359889861253 <br>0682630534 <br>0687006530 <br>0687006530 <br>0650546439</li>
            </ul>
            <hr>
            <h3>Created by<img src="LogoT.png"></h3>
            <p>Copyright &copy; All rights reserved.</p>
        </div>
    </footer>
         <script type="text/javascript" src="js.js"></script>
</body>
</html>