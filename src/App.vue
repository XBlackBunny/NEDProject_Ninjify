<template>
  <div id="app">
    <img alt="Vue logo" src="./assets/ninjabrian1.png">
    <NinjaNameGenerator/>
  </div>
</template>

<script>
import NinjaNameGenerator from './components/NinjaNameGenerator.vue'

export default {
  name: 'App',
  components: {
    NinjaNameGenerator
  }
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
