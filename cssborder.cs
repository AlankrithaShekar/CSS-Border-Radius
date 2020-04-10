.border{
                border:2px solid black;
                border-radius: var(--valuet) var(--valuel) var(--valueb) var(--valuer);
                text-align: center;
                display: flex;
                width:50%;
                align-items:center;
                flex:1;
                flex-direction: column;
                justify-content: center;
                border-width: 1px;
                padding: 50px;
                max-width: 500px;
                margin-top: 8%;
                background-color: green;
            }
            .p{
                text-align: center;
            }
            .body{
                display: flex;
                flex: 1;
                 flex-direction: column;
                align-items: center;
                justify-content: center;

    /*font-family: 'Roboto', sans-serif;*/
            }
            .tooltip {
  position: relative;
  display: inline-block;
}

.tooltip .tooltiptext {
  visibility: hidden;
  width: 140px;
  background-color: #555;
  color: #fff;
  text-align: center;
  border-radius: 6px;
  padding: 5px;
  position: absolute;
  z-index: 1;
  bottom: 150%;
  left: 50%;
  margin-left: -75px;
  opacity: 0;
  transition: opacity 0.3s;
}

.tooltip .tooltiptext::after {
  content: "";
  position: absolute;
  top: 100%;
  left: 50%;
  margin-left: -5px;
  border-width: 5px;
  border-style: solid;
  border-color: #555 transparent transparent transparent;
}

.tooltip:hover .tooltiptext {
  visibility: visible;
  opacity: 1;
}
