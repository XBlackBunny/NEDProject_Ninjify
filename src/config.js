let config;

if(process.env.VUE_APP_ENV !== 'dev'){
  config = {
    api: process.env.VUE_APP_URL
  }
} else {
  config = {
    api: 'Localhost'
  }
}

export { config }