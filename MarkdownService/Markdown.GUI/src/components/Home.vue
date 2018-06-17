<template>
	<div>
		<h2>Your documents</h2>
		<b-table :items=documents :fields="documentFields">
			<template slot="actions" slot-scope="data">
				<div class="float-right">
					<b-btn variant="light" class="pointer">
						<a href=""><span class="fa fa-edit"></span></a>
					</b-btn>
					<b-btn variant="light" class="pointer">
						<router-link :to="{ name: 'ReadDocument', params: { docid: data.item.id }}"><span class="fa fa-eye"></span></router-link>
					</b-btn>
				</div>
			</template>
		</b-table>
	</div>
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
        { key: "name", label: "" },
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
