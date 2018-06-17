<template>
	<div>
		<navigation></navigation>
		<div id="app">
			<b-container>
				<router-view></router-view>
			</b-container>
		</div>
	</div>
</template>

<script>
import Navigation from "@/components/blocks/navigation";
export default {
  name: "app",
  components: {
    navigation: Navigation
  }
};
</script>