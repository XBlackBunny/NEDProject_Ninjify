import Vue from 'vue'
import App from './App.vue'
import { config } from './config'

Vue.config.productionTip = false
Vue.prototype.appConfig = config

new Vue({
  render: h => h(App),
}).$mount('#app')
