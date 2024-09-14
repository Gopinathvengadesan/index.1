const bodyEl = document.querySelector("body")

bodyEl.addEventListener("mousemove", ()=>{
    const xPos = event.offsetX;
    const yPos = event.offsetY;
    const spanEl = document.createElement("span");
    spanEl.style.left = xPos + "px";
    spanEl.style.left = yPos + "px";
    bodyEl.appendChild(spanEl);

} )