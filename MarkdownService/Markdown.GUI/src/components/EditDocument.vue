<template>
    <b-row>
		<b-col offset-md="1" md=8 class="headerSpace">
			<h2>{{title}}</h2>
		</b-col>
		<b-col md=2 class="text-right">
			<b-btn @click="SaveDocument">
				Save
			</b-btn>
		</b-col>

        <b-col offset-md="1" md=5>
            <textarea class="editor" v-model="markdown"></textarea>
        </b-col>
        <b-col md=5 id="MDDoc">
        </b-col>
		<hr>
    </b-row>
</template>
<script>
import showdown from "showdown";

export default {
  name: "EditDocument",
  data: () => {
    return {
      id: "",
      title: "",
      markdown: {}
    };
  },
  created() {
    this.id = this.$route.params.docid;
    fetch(Settings.BaseUrl + "/documents/" + this.id)
      .then(response => {
        return response.text();
      })
      .then(responseBody => {
        var data = JSON.parse(responseBody);
        this.title = data.title;
        this.markdown = data.markdown;
      });
  },
  watch: {
    markdown: newMarkdown => {
      let converter = new showdown.Converter();
      let html = converter.makeHtml(newMarkdown);
      document.getElementById("MDDoc").innerHTML = html;
    }
  },
  methods: {
    SaveDocument() {
      let doc = {
        ID: this.id,
        Title: this.title,
        Markdown: this.markdown
      };

      console.log("doc", doc);
      fetch(Settings.BaseUrl + "/documents/" + this.id, {
        method: "put",
        headers: {
          "Content-type": "application/json; charset=UTF-8"
        },
        body: doc
      });
    }
  }
};
</script>
<style scoped>
.editor {
  width: 100%;
  height: 100%;
}

.headerSpace {
  padding-bottom: 2em;
}
</style>
