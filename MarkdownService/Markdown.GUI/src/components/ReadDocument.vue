<template>
	<b-container>
    	<b-row>
			<b-col offset-lg="2" lg="8" offset-md="1" md="10" sm=12>
				<div>
					<h1>{{title}}</h1>
				</div>
				<div md="6" offset-md="3" id="MDDoc" class="document">
				</div>
			</b-col>
    	</b-row>
	</b-container>
</template>
<script>
import showdown from "showdown";

export default {
  name: "ReadDocument",
  data() {
    return {
      id: "",
      title: "",
      md: ""
    };
  },
  mounted() {
    this.id = this.$route.params.docid;
    fetch(Settings.BaseUrl + "/documents/" + this.id)
      .then(response => {
        return response.text();
      })
      .then(responseBody => {
        var data = JSON.parse(responseBody);
        this.md = data.markdown;
        this.title = data.title;
      });
  },
  watch: {
    md: newValue => {
      let converter = new showdown.Converter();
      let html = converter.makeHtml(newValue);
      document.getElementById("MDDoc").innerHTML = html;
    }
  }
};
</script>

<style scoped>
.document {
  padding: 2em;

  -moz-box-shadow: 0 0 3px #ccc;
  -webkit-box-shadow: 0 0 3px #ccc;
  box-shadow: 0 0 3px #ccc;
}
</style>
