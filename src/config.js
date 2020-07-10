let config;
if(process.env.NODE_ENV === 'prod'){
  config = {
    api: "https://ninjifyweb.azurewebsites.net/"
  }
} else {
  config = {
    api: "https://localhost:44389/"
  }
}

export { config }