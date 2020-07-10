<template>
  <div class="hello">
    <template v-if="executeOrderFourTwenty">
      <a v-bind:href="orderFourTwenty"><p>{{ninjaName}}</p></a>
    </template>
    <template v-if="!executeOrderFourTwenty">
      <p>{{ninjaName}}</p>
    </template>
    <input v-model="genSource">
    <button v-on:click="generateNinjaName">Generate</button>
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
      orderFourTwenty:'https://bit.ly/2ZcKZ3G',
      genSource: '',
      executeOrderFourTwenty:false
    }
  },
  methods:{
    generateNinjaName: function(){
      if(!this.genSource || this.genSource.length > 24 || this.genSource.length < 2){
        this.ninjaName = "The value length is not suitable to generate a name correctly. It must be between 2 and 24 characters.";
      } else {
        axios.get(this.appConfig.api + 'Ninjify?x=' + this.genSource)
        .then(response => 
         this.ninjaName = response.data.hasError 
            ? response.data.errorMessage === "420" ? response.data.result
            : response.data.errorMessage 
            : response.data.result);

        this.executeOrderFourTwenty = this.genSource === "↑↑↓↓←→←→ba";
      }
    }
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
</style>
