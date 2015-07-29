var nextTurn = 'X';
var turnCount = 0;
var gameOver = false;
// Anonymous function for the page load
window.onload = function () {
    $(":submit").bind('click', btnxy_Click);
}


function btnxy_Click(e) {
    
    // Debug: to test the btnID for each button clicked
    //alert(e.target.id);
    //alert( ($("#" + btn21).val()));
     
    $('#' + e.target.id).val(nextTurn);     // Outputs X for the first click
    $("#" + e.target.id).unbind('click');   // Prevents user from clicking on the square that is already selected
    //Increment the turnCount
    turnCount = turnCount + 1; 
      
    // Alternates the turn between X and Y
    if (nextTurn == 'X') {

        nextTurn = 'Y';
        
    }

    else {
        nextTurn = 'X';
    }
     
    isWin();
    if(gameOver)
    {
       $("#btn11").unbind('click');
       $("#btn12").unbind('click');
       $("#btn13").unbind('click');
       $("#btn21").unbind('click');
       $("#btn22").unbind('click');
       $("#btn23").unbind('click');
       $("#btn31").unbind('click');
       $("#btn32").unbind('click');
       $("#btn33").unbind('click');
    }
    /*
    * If Game is over then disable all the buttons from being clicked, even the ones that are not clicked
    *
    */
}

// Matches all the 8 possibilities of line in the tic tac toe game 
function isWin()
{ 
  //Exhaustively checks all possibilities which shouldnt be too slow
  //given the small input instance

  //Horizontal wins
  //Top Row
  if($("#btn11").val() == $("#btn12").val() && $("#btn12").val() == $("#btn13").val())
  {
      if( $("#btn11").val() == "X")
      {
        $("#msg_box").val("Game over X wins" );
        gameOver = true;
      }
      else if ( $("#btn11").val() == "Y")
      {
        $("#msg_box").val("Game over Y wins" ); 
        gameOver = true;
      }
  }
  //Middle Row
  if($("#btn21").val() == $("#btn22").val() && $("#btn22").val() == $("#btn23").val())
  {
      if( $("#btn21").val() == "X")
      {
        $("#msg_box").val("Game over X wins" );
        gameOver = true;
      }
      else if ( $("#btn21").val() == "Y")
      {
        $("#msg_box").val("Game over Y wins" ); 
        gameOver = true;
      }
  }
  //Bottom row
  if($("#btn31").val() == $("#btn32").val() && $("#btn32").val() == $("#btn33").val())
  {
      if( $("#btn31").val() == "X")
      {
        $("#msg_box").val("Game over X wins" );
        gameOver = true;
      }
      else if ( $("#btn31").val() == "Y")
      {
        $("#msg_box").val("Game over Y wins" ); 
        gameOver = true;
      }
  }
  //Vertical Wins
  //Left column
  if($("#btn11").val() == $("#btn21").val() && $("#btn21").val() == $("#btn31").val())
  {
      if( $("#btn11").val() == "X")
      {
        $("#msg_box").val("Game over X wins" );
        gameOver = true;
      }
      else if ( $("#btn11").val() == "Y")
      {
        $("#msg_box").val("Game over Y wins" ); 
        gameOver = true;
      }
  }
  //Middle Column
  if($("#btn12").val() == $("#btn22").val() && $("#btn22").val() == $("#btn32").val())
  {
      if( $("#btn12").val() == "X")
      {
        $("#msg_box").val("Game over X wins" );
        gameOver = true;
      }
      else if ( $("#btn12").val() == "Y")
      {
        $("#msg_box").val("Game over Y wins" ); 
        gameOver = true;
      }
  }
  //Right column
  if($("#btn13").val() == $("#btn23").val() && $("#btn23").val() == $("#btn33").val())
  {
      if( $("#btn13").val() == "X")
      {
        $("#msg_box").val("Game over X wins" );
        gameOver = true;
      }
      else if ( $("#btn13").val() == "Y")
      {
        $("#msg_box").val("Game over Y wins" ); 
        gameOver = true;
      }
  }
  //Diagonal top left to bottom-right
  if($("#btn11").val() == $("#btn22").val() && $("#btn22").val() == $("#btn33").val())
  {
      if( $("#btn11").val() == "X")
      {
        $("#msg_box").val("Game over X wins" );
        gameOver = true;
      }
      else if ( $("#btn11").val() == "Y")
      {
        $("#msg_box").val("Game over Y wins" ); 
        gameOver = true;
      }
  }
  //Diagonal top right to bottom-left
  if($("#btn13").val() == $("#btn22").val() && $("#btn22").val() == $("#btn31").val())
  {
      if( $("#btn13").val() == "X")
      {
        $("#msg_box").val("Game over X wins" );
        gameOver = true;
      }
      else if ( $("#btn13").val() == "Y")
      {
        $("#msg_box").val("Game over Y wins" ); 
        gameOver = true;
      }
  }
  //Lastly if all the moves have been taken
  if(turnCount >= 9)
  {
    $("#msg_box").val("Game over" ); 
    gameOver = true;
  }
}


