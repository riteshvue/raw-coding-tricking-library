<template>
  <div class="text-4xl bg-slate-600 p-4">test document {{ message }}</div>
</template>
<script>
import Axios from "axios";
export default {
  data() {
    return {
      message: "",
    };
  },
  created() {
    Axios.get("https://localhost:7163/api/home")
      .then(({ data }) => {
        this.message = data;
        console.log(data);
      })
      .catch((err) => {
        console.log(err);
      });
  },
};
</script>
