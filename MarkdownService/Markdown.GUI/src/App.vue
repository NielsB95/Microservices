<template>
	<div>
		<navigation></navigation>
		<div id="app">
			<router-view></router-view>
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