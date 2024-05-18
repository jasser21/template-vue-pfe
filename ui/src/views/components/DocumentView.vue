<template>
  <div v-if="!document" class="loading">
    // Loading spinner
    <div class="spinner"></div>
  </div>
  <div v-else class="document-view">
    <h1>{{ document.name }}</h1>
    <p class="description">{{ document.description }}</p>
    <div class="info">
      <p><span>Added Date:</span> {{ formatDate(document.addedDate) }}</p>
      <p><span>Updated Date:</span> {{ formatDate(document.updatedDate) }}</p>
      <p><span>Status:</span> {{ getStatusText(document.status) }}</p>
      <p v-if="document.ocrText"><span>OCR Text:</span> {{ document.ocrText }}</p>
      <p><span>Document State:</span> {{ document.documentState }}</p>
      <p><span>Content Type:</span> {{ document.contentType }}</p>
    </div>
  </div>
</template>

<script setup>
import { ref, onMounted } from 'vue';
import BaseApiService from '../../services/apiService';
import { useRoute } from 'vue-router';
const route = useRoute();
const document = ref();

const fetchDocument = async () => {

  const documentId = route.params.id;
  const response = await BaseApiService('document').get(documentId);
  document.value = response.data;
  console.log(document.value);
};

const formatDate = (date) => {
  return new Date(date).toLocaleDateString();
};

const getStatusText = (status) => {
  return status === 0 ? "Pending" : "Completed";
};
onMounted(() => fetchDocument());
</script>

<style scoped>
.document-view {
  width: 80%;
  margin: 2rem auto;
  padding: 2rem;
  box-shadow: 0px 4px 8px rgba(0, 0, 0, 0.1);
  border-radius: 8px;
  background-color: #fff;
  font-family: 'Arial', sans-serif;
}

.document-view h1 {
  font-size: 2.5rem;
  color: #333;
  margin-bottom: 1rem;
  border-bottom: 2px solid #eee;
  padding-bottom: 0.5rem;
}

.document-view .description {
  font-size: 1.25rem;
  color: #555;
  margin-bottom: 1.5rem;
}

.document-view .info {
  font-size: 1rem;
  color: #666;
}

.document-view .info p {
  margin-bottom: 0.75rem;
}

.document-view .info span {
  font-weight: bold;
  color: #333;
}
</style>
