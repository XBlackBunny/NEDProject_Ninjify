<template>
  <div class="hello">
    <p>{{ninjaName}}</p>
    <input v-model="genSource">
    <button v-on:click="generateNinjaName">I want text here</button>
  </div>
</template>

<script>
import axios from 'axios'

export default {
  name: 'NinjaNameGenerator',
  props: {
    MyProp: String
  },
  data: function(){
    return {
      ninjaName:'No name has been generated yet.',
      genSource:''
    }
  },
  methods:{
    generateNinjaName: function(){
      if(!this.genSource){ // field too small or empty

      } else {
        axios.get('https://ninjifywebapi.azurewebsites.net/Ninjify?techname=' + this.genSource).then(response => this.ninjaName = response.data)
      }
    }
  }

}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
</style>
