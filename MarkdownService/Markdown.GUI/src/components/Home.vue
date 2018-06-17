<template>
	<b-container>
		<b-row>
			<b-col md=12>
				<h2>Your documents</h2>
			</b-col>
			<b-col md=12>
				<b-row v-for="doc in documents" v-bind:key="doc.id">
						<b-col offset-md="1" md="8">
							{{doc.title}}
						</b-col>
						<b-col md="3" class="float-right">
							<router-link :to="{ name: 'EditDocument', params: { docid: doc.id }}">
								<b-btn variant="light" class="pointer">
									<span class="fa fa-edit"></span>
								</b-btn>
							</router-link>
							<router-link :to="{ name: 'ReadDocument', params: { docid: doc.id }}">
								<b-btn variant="light" class="pointer">
									<span class="fa fa-eye"></span>
								</b-btn>
							</router-link>
						</b-col>
				</b-row>
			</b-col>
		</b-row>
	</b-container>
</template>

<script>
export default {
  name: "Home",
  created() {
    fetch(Settings.BaseUrl + "/documents")
      .then(response => {
        return response.text();
      })
      .then(responseBody => {
        var data = JSON.parse(responseBody);
        this.documents = data;
      });
  },
  data() {
    return {
      documents: [],
      documentFields: [
        { key: "title", label: "" },
        { key: "actions", label: "" }
      ]
    };
  }
};
</script>
<style scoped>
.pointer {
  cursor: pointer;
}
</style>
