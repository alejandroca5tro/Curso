  var domSubCurso = document.querySelector("#sCurso");
  
 var web = ["HTML", "Css", "JavaSCript", "PHP"];
 var sist = ["aaaa", "bbbb", "cccc", "dddd"];
 var obj =  ["1111", "2222", "3333", "4444"]
    function cargarSelect(oDom, aDatos) {
        oDom.innerHTML = "";
        for (var i = 0; i < aDatos.length; i++) {
            oDom.innerHTML += "<option>" + aDatos[i] + "</option>";
        }
    }
           
          
   function doIt(the_value) {
       switch (the_value) {
           case "web":
              cargarSelect(domSubCurso,web)
               break;

           case "sist":
              cargarSelect(domSubCurso,sist)
               break;

           case "obj":
               cargarSelect(domSubCurso,obj)
               break;

       }
   }
      