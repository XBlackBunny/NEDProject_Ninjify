let config;
if(process.env.NODE_ENV !== 'dev'){
  config = {
    api: "https://ninjifyweb.azurewebsites.net/"
  }
} else {
  config = {
    api: process.env.URL
  }
}

export { config }