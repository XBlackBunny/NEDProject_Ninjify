let config;
if(process.env.NODE_ENV !== 'dev'){
  config = {
    api: process.env.URL
  }
} else {
  config = {
    api: 'Localhost'
  }
}

export { config }