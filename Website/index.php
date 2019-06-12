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
    <title>Escalate Music Festival</title>
    <link rel="stylesheet" type="text/css" href="home.css">
</head>
<body>
    <header>
 <div class="navbar">
     <img src="mini%20logo.png" alt="logo" class="logo">
     <nav>
  <ul>
    <li><a href="#">Home</a></li>
    <li><a href="#AboutUs">About us</a></li>
    <li><a href="Buy%20Tickets.php">Buy Tickets</a></li>
    <li><a href="Line-Up.php">Line-Up</a></li>
    <li><a href="#EventInfo">Event Info</a></li>
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
    <div class="logopic">
    <img src="Event%20Logo.jpg">
    </div>
    <div class="container" id="EventInfo">
        <div class="rightside">
        <img src="Eventpic1.jpg">
        <img src="Eventpic2.jpg">
        <img src="eventpic3.jpg">
            <img src="Eventpic4.jpg">
            <img src="Eventpic5.jpg">
            <img src="Eventpic6.jpg">
            <img src="Eventpic7.jpg">
            <img src="Eventpic8.jpg">
            <img src="Eventpic9.jpg">
            <img src="Eventpic10.jpg">
            <img src="Eventpic11.jpg">
        </div>
    <div class="eventinfo">
            <h1>Event Info</h1>
        <p>Are you ready for things to escalate? This July for the first time making it's debut is the biggest event so far. With one of the the most popular performers like David Guetta,Afrojack,Steve Aoki and many more taking over the stage. Come to listen to your favourite music and escalate with us. Buy tickets now for the biggest musical event ever seen "Escalate Music Festival".A two day long event with a lot of good music and plenty of good time waiting for you.Come ESCALATE the summer with "Escalate Music Festival".
        <br>On the right you can see some pictures from previous events organized by us.
        </p>
    </div>
    </div>
    <div class="container2" id="AboutUs">
        <div class="leftside">
            <h1>Fruequently Asked Questions (FAQ)</h1>
            <button class="accordion">Lost your ticket?</button>
            <div class="panel">
                <p>When buyng a ticket from the website you recieve an unique identification code.You can use this code to get a new ticket.</p>
            </div>
            <button class="accordion">Can't come anymore?</button>
            <div class="panel">
                <p>There are no refunds. Every ticket has and unique event id to it.</p>
            </div>
            <button class="accordion">Can somebody else use my ticket?</button>
            <div class="panel">
                <p>That is not possible.Every ticket has an unique id connected to your name even if someone uses your ticket but the names do not match he can not enter the event. </p>
            </div>
            <button class="accordion">When does it start?</button>
            <div class="panel">
                <p>The festival begins Saturday 13th of July at 14:30.</p>
            </div>
            <button class="accordion">What is the minimum age?</button>
            <div class="panel">
                <p>The minimum age is 18 old.However if it's with an authorized adult or a parental figure minors will also be allowed.</p>
            </div>
            <button class="accordion">Lost and Found</button>
            <div class="panel">
                <p>All lost items can be reclaimed on Monday 15th of July in our temporary office at the site of the event.</p>
            </div>
            <button class="accordion">Other questions</button>
            <div class="panel">
                <p>Did we answer all your questions? If not you can send us an e-mail with your quiestion or questions on our e-mail adress.</p>
            </div>
        </div>
    <div class="about">
        <h1>About Us</h1>
        <p>We are a company that specializes in creating and managing big musical and other type of events.
        If you have interest in coming to another of our events you can folow us on Facebook,Twitter and/or Instagram.
        As we grow we need more and more personnel and help so we will be glad if you choose to follow us in any of our adventures.</p>
    </div>
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